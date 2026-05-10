// JavaScript source code
/* 1. Area of a triangle with sides 5, 6, 7 */
(function () {
    let a = 5, b = 6, c = 7;
    let s = (a + b + c) / 2;
    let area = Math.sqrt(s * (s - a) * (s - b) * (s - c));
    console.log("Area of the triangle:", area);
})();


/* 2. Pattern using nested for loop */
(function () {
    let pattern = "";
    for (let i = 1; i <= 5; i++) {
        for (let j = 1; j <= i; j++) {
            pattern += "* ";
        }
        pattern += "\n";
    }
    console.log(pattern);
})();


/* 3. Leap year checker */
(function () {
    let year = 2024; 

    if ((year % 4 === 0 && year % 100 !== 0) || year % 400 === 0) {
        console.log(year + " is a Leap Year");
    } else {
        console.log(year + " is NOT a Leap Year");
    }
})();


/* 4. Days left until Independence Day (August 15) */
(function () {
    let today = new Date();
    let year = today.getFullYear();
    let independenceDay = new Date(year, 7, 15); // August = 7

    if (today > independenceDay) {
        independenceDay = new Date(year + 1, 7, 15);
    }

    let diffTime = independenceDay - today;
    let diffDays = Math.ceil(diffTime / (1000 * 60 * 60 * 24));

    console.log("Days left until Independence Day:", diffDays);
})();