# EasyValueToRef

将一个值转换为一个引用，以实现在不同类中共享一个值等功能

## 用法

```csharp
using EasyValueToRef;

Ref<int> a = 2;
Ref<int> b = 1;

Ref<bool> v = true;
var cc = a;
if (v)
{
    Console.WriteLine("v is true");
}

var bb = v;

bb.SetValue(false);

Console.WriteLine(v);
if (v)
{
    Console.WriteLine("v is true");
}

Console.WriteLine(a + 32);
a.SetValue(a - 32);
if (a == 1)
{
    Console.WriteLine("a big than 1");
}
else if (a == 1)
{
    Console.WriteLine("a equal with 1");
}
else
{
    Console.WriteLine("a small than 1");
}
```