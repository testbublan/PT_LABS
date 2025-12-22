using CS_Static;

Vector3D v1 = new Vector3D(1, 2, 3);
Vector3D v2 = new Vector3D(-4, 5, 0);

Console.WriteLine(v1);
Console.WriteLine(v2);

Vector3D sum = v1 + v2;
Vector3D diff = v1 - v2;
double dot = v1 * v2;

Console.WriteLine($"v1 + v2 = {sum}");
Console.WriteLine($"v1 - v2 = {diff}");
Console.WriteLine($"v1 * v2 (dot) = {dot}");

Console.WriteLine($"v1 Equals v2? {v1.Equals(v2)}");
Console.WriteLine($"v1 Equals (1,2,3)? {v1.Equals(new Vector3D(1, 2, 3))}");