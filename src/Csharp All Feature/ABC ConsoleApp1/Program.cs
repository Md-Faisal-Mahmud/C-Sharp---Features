var arr = new[]                                         // Array of Anonymous Types
{
    new { Firstname = "Muhammad", Lastname = "Salman"},
    new { Firstname = "faisal", Lastname = "mahmud"},
    new { Firstname = "salman" , Lastname = "nur"}

};

foreach (var item in arr)
{
    Console.WriteLine(item.Firstname + " " + item.Lastname);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i].Firstname + " " + arr[i].Lastname);
}
