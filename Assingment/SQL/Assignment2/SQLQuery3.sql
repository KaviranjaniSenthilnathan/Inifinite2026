create function dbo.fnRectangleArea(@Length int,@Width  int)
returns int
as
begin
return @Length * @Width;
end;
SELECT dbo.fnRectangleArea(10, 5);
