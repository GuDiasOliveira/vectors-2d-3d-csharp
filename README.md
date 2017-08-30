# C# Vectors 2D and 3D

## Basic operations between vectors

You can do basic operations with the vectors.

```cs
Vector3D v1 = new Vector3D(1, 2, -1);
Vector3D v2 = new Vector3D(5, 1, -2);
Vector3D res;
// ...
res = v1 + v2; // res = (X = 6, Y = 3, Z = -3)
// ...
res = v1 - v2; // res = (X = -4, Y = 1, Z = 1)
// ...
res = v1 * 3; // res = (X = 3, Y = 6, Z = -3)
// ...
res = v2 / 2; // res = (X = 2.5, Y = 0.5, Z = -1)
```

```cs
Vector2D vect1 = new Vector2D(-2, 1);
Vector2D vect2 = new Vector2D(0.5, 2);
Vector2D res;
// ...
res = vect1 + vect2; // res = (X = -1.5, Y = 3)
// ...
res = vect1 - vect2; // res = (X = -2.5, Y = -1)
// ...
res = vect1 * (-4); // res = (X = 8, Y = -4)
// ...
res = vect2 / 10; // res = (X = 0.05, Y = 0.2)
```

```cs
Vector2D v2d = new Vector2D(1, 2);
Vector3D v3d = new Vector3D(-1, 3, 1);
Vector3D res = v2d + v3d; // res = (X = 1-1, Y = 2+3, Z = 0+1) = (X = 0, Y = 5, Z = 1)
```

## Dot product

To make a dot product between two vectors, use the ```*``` operator

```cs
Vector3D v1 = new Vector3D(1, 2, -1);
Vector3D v2 = new Vector3D(5, 1, -2);
double dotProduct = v1 * v2; // dotProduct = 1*5 + 2*1 + (-1)*(-2) = 9.0
```

## Cross product

To make a cross product between two vectors, use the operator ```&```

```cs
Vector3D v1 = new Vector3D(1, 2, -3);
Vector3D v2 = new Vector3D(-9, 0, 3);
Vector3D v1crossv2 = v1 & v2;
```

## 2D Vector to 3D Vector

A 2D vector is automatically converted to a 3D vector, with Z = 0.

```cs
Vector2D v1 = new Vector2D(2, -5);
Vector3D v2 = v1; // v2 = (X = 2, Y = -5, Z = 0)
```

## 3D Vector to 2D Vector

You can cast a 3D vector to a 2D vector. Then the Z value will be discarded.

```cs
Vector3D v1 = new Vector3D(1, -2, 9);
Vector2D v2 = (Vector2D) v1; // v2 = (X = 1, Y = -2)
```
