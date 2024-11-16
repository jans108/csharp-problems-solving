using Processing1DArrays;

var a = new int[] { -2, -1, 0, 1, 4 };
var b = new int[] { -2, -1, 0, 1, 4, 5, 6 };

var c = new int[] { -2, -1, 0, 1, 4 };
var d = new int[] { -3, -2, -1, 1, 2, 3 };

PrintArray.Print(a, b);
PrintArray.Print(c, d);

Console.WriteLine();

var e = new int[] { 0, 1, 1, 2, 3, 3, 3 };
var f = new int[] { 0, 2, 2, 3, 4 };

PrintArray.Print(e, f);

Console.WriteLine();

var g = new int[] { 0, 1, 1, 2, 3, 3, 3 };
var k = new int[] { 1, 2, 2, 3, 4 };

PrintArray.Print(g, k);

Console.WriteLine();

var i = new int[] { 0, 1, 1, 2, 3, 3, 3 };
var j = new int[] { -1, 4, 5, 5, 6, 6 };

PrintArray.Print(i, j);

Console.WriteLine();

var a1 = new int[] { -2, -1, 0, 1, 4 };
var a2 = new int[] { -3, -2, -1, 1, 2, 3 };

PrintV2Array.Print(a1, a2);

Console.WriteLine();

var b1 = new int[] { 0, 1, 1, 2, 3, 3, 3 };
var b2 = new int[] { 0, 1, 2, 3, 3 };

PrintV2Array.Print(b1, b2);

Console.ReadLine();