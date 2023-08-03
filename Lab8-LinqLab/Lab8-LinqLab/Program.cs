int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

var minValue = nums.Min();
Console.WriteLine($"Minimum Value: {minValue}");

var maxValue = nums.Max();
Console.WriteLine($"Maximum Value: {maxValue}");

var maxValueUnder10000 = nums.Where(x => x < 10000).Max();
Console.WriteLine($"Maximum Value less than 10000: {maxValueUnder10000}");

var valuesBetween10And100 = nums.Where(x => x > 10 && x < 100).ToArray();
Console.WriteLine($"Values between 10 and 100: {string.Join(", ", valuesBetween10And100)}");

var valuesBetween100000And999999 = nums.Where(x => x >= 100000 && x <= 999999).ToArray();
Console.WriteLine($"Values between 100000 and 999999 inclusive: {string.Join(", ", valuesBetween100000And999999)}");

var evenNumberCount = nums.Where(x => x % 2 == 0).Count();
Console.WriteLine($"Count of Even Numbers: {evenNumberCount}");