// See https://aka.ms/new-console-template for more information
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


bb.Value = true;

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

MyClass my = new MyClass();

MyClass2 myClass2 = new MyClass2(my.bool1);
Console.WriteLine(myClass2.bool1);
my.bool1.SetValue(true);
Console.WriteLine(myClass2.bool1);

class MyClass
{
    public Ref<bool> bool1 = false;
    public Ref<int> Num = 1;

   
}

class MyClass2
{
    public Ref<bool> bool1 = false;
    public Ref<int> Num = 1;

    public MyClass2(Ref<bool> b)
    {
        bool1 = b;
    }
}

