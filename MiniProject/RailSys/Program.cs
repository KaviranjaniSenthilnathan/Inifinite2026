using System;
using System.Collections.Generic;
using System.Data.SqlClient;

class RailApp
{
    static string cs = "Server=ICS-LT-F0W37V3\\SQLEXPRESS01;Database=RailSys;Trusted_Connection=True;";
    static SqlConnection conn = new SqlConnection(cs);

    static void Header(string txt)
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine($"     {txt.ToUpper()}");
        Console.WriteLine("=======================================");
    }

    static int GetInt()
    {
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
            Console.WriteLine("Invalid number!");
        return x;
    }

    static void Main()
    {
        while (true)
        {
            Header("Rail Reservation");

            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");

            if (GetInt() == 2) break;

            Console.Write("Username: ");
            string u = Console.ReadLine();

            Console.Write("Password: ");
            string p = Console.ReadLine();

            SqlCommand check = new SqlCommand(
                "SELECT UserId FROM AccountUsers WHERE UserName=@u AND Password=@p", conn);

            check.Parameters.AddWithValue("@u", u);
            check.Parameters.AddWithValue("@p", p);

            conn.Open();
            var r = check.ExecuteReader();

            if (!r.Read())
            {
                Console.WriteLine("Invalid login!");
                conn.Close();
                continue;
            }

            int uid = (int)r["UserId"];
            conn.Close();

            UserMenu(uid);
        }
    }

    static void UserMenu(int uid)
    {
        while (true)
        {
            Header("User Menu");

            Console.WriteLine("1. Book Ticket");
            Console.WriteLine("2. View My Tickets");
            Console.WriteLine("3. Cancel Ticket");
            Console.WriteLine("4. Back");

            int ch = GetInt();

            if (ch == 1) Book(uid);
            else if (ch == 2) ViewBookings(uid);
            else if (ch == 3) Cancel(uid);
            else break;

            Console.ReadKey();
        }
    }

    static void Book(int uid)
    {
        Header("Book Seat");

        conn.Open();

        var dr = new SqlCommand("SELECT * FROM TrainMaster WHERE IsActive=1", conn)
            .ExecuteReader();

        List<int> trains = new List<int>();
        int i = 1;

        while (dr.Read())
        {
            trains.Add((int)dr["TrainId"]);
            Console.WriteLine($"{i}. {dr["TrainTitle"]} ({dr["Source"]} → {dr["Destination"]})");
            i++;
        }

        dr.Close();

        int trId = trains[GetInt() - 1];

        // get booked seats
        SqlCommand cmd = new SqlCommand(@"
        SELECT SeatNo FROM Travellers t
        JOIN TicketBooking b ON t.PNR=b.PNR
        WHERE b.TrainId=@t AND t.IsCancelled=0", conn);

        cmd.Parameters.AddWithValue("@t", trId);

        var sdr = cmd.ExecuteReader();

        List<int> used = new List<int>();

        while (sdr.Read())
            used.Add((int)sdr["SeatNo"]);

        sdr.Close();

        List<int> free = new List<int>();

        for (int s = 1; s <= 50; s++)
            if (!used.Contains(s)) free.Add(s);

        Console.WriteLine("\nAvailable Seats:");
        free.ForEach(x => Console.Write(x + " "));

        Console.Write("\nPassengers (max 3): ");
        int cnt = GetInt();

        if (cnt > 3 || cnt > free.Count)
        {
            Console.WriteLine("Invalid count!");
            conn.Close();
            return;
        }

        int pnr = new Random().Next(100000, 999999);

        new SqlCommand(@"
        INSERT INTO TicketBooking VALUES(@p,GETDATE(),@t,@c,@amt,@u)", conn)
        {
            Parameters = {
                new SqlParameter("@p", pnr),
                new SqlParameter("@t", trId),
                new SqlParameter("@c", cnt),
                new SqlParameter("@amt", cnt * 100),
                new SqlParameter("@u", uid)
            }
        }.ExecuteNonQuery();

        for (int k = 0; k < cnt; k++)
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = GetInt();

            Console.Write("Gender (M/F): ");
            string g = Console.ReadLine().ToUpper();

            Console.Write("Proof (Aadhaar/PAN/Passport): ");
            string pt = Console.ReadLine();

            Console.Write("Proof Number: ");
            string pn = Console.ReadLine();

            int seat;

            while (true)
            {
                Console.Write("Select seat: ");
                seat = GetInt();

                if (free.Contains(seat)) break;
                Console.WriteLine("Invalid seat!");
            }

            free.Remove(seat);

            new SqlCommand(@"
            INSERT INTO Travellers
            (PNR,FullName,Age,Gender,ProofType,ProofNumber,SeatNo)
            VALUES(@p,@n,@a,@g,@pt,@pn,@s)", conn)
            {
                Parameters = {
                    new SqlParameter("@p", pnr),
                    new SqlParameter("@n", name),
                    new SqlParameter("@a", age),
                    new SqlParameter("@g", g),
                    new SqlParameter("@pt", pt),
                    new SqlParameter("@pn", pn),
                    new SqlParameter("@s", seat)
                }
            }.ExecuteNonQuery();
        }

        conn.Close();

        Console.WriteLine($"\n✅ Booked Successfully! PNR: {pnr}");
    }

    static void ViewBookings(int uid)
    {
        Header("My Tickets");

        conn.Open();

        var dr = new SqlCommand(
            "SELECT PNR FROM TicketBooking WHERE UserId=@u", conn);

        dr.Parameters.AddWithValue("@u", uid);

        var reader = dr.ExecuteReader();

        List<int> pnrs = new List<int>();
        int i = 1;

        while (reader.Read())
        {
            pnrs.Add((int)reader["PNR"]);
            Console.WriteLine($"{i}. PNR {pnrs[i - 1]}");
            i++;
        }

        reader.Close();

        if (pnrs.Count == 0)
        {
            Console.WriteLine("No bookings!");
            conn.Close();
            return;
        }

        int selected = pnrs[GetInt() - 1];

        var pdr = new SqlCommand(
            "SELECT * FROM Travellers WHERE PNR=@p", conn);

        pdr.Parameters.AddWithValue("@p", selected);

        var r = pdr.ExecuteReader();

        while (r.Read())
        {
            Console.WriteLine("\n-------------------");
            Console.WriteLine(r["FullName"] + " - Seat " + r["SeatNo"]);
        }

        conn.Close();
    }

    static void Cancel(int uid)
    {
        Header("Cancel");

        Console.Write("Enter PNR: ");
        int pnr = GetInt();

        conn.Open();

        var dr = new SqlCommand(
            "SELECT SeatNo, FullName FROM Travellers WHERE PNR=@p AND IsCancelled=0", conn);

        dr.Parameters.AddWithValue("@p", pnr);

        var r = dr.ExecuteReader();

        List<int> seats = new List<int>();

        while (r.Read())
        {
            int s = (int)r["SeatNo"];
            seats.Add(s);
            Console.WriteLine($"{s} - {r["FullName"]}");
        }

        r.Close();

        Console.Write("Select Seat: ");
        int choice = GetInt();

        new SqlCommand(
            "UPDATE Travellers SET IsCancelled=1 WHERE PNR=@p AND SeatNo=@s", conn)
        {
            Parameters = {
                new SqlParameter("@p", pnr),
                new SqlParameter("@s", choice)
            }
        }.ExecuteNonQuery();

        conn.Close();

        Console.WriteLine("Cancelled!");
    }
}
