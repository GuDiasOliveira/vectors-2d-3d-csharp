# C# Vectors 2D and 3D

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
