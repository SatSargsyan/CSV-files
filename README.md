# Ref vs Out

<h3>They're pretty much the same - the only difference is that a variable you pass as an out parameter doesn't need to be initialized but passing it as a ref parameter it has to be set to something.</h3>
```C#
int x;
Foo(out x); // OK

int y;
Foo(ref y); // Error: y should be initialized before calling the method
```
```C#
            int a = 5;
            int b = 15;
            Console.WriteLine("after calling method swap {0}, {1}", a, b);
            swap(ref a,ref b);
            Console.WriteLine("after calling method swap {0}, {1}", a, b);
```
####If we don't use ref, after swap a and b don't change their values

```C#
public static void swap(ref int  a, ref int  b)
        {
            int t = a;
            a = b;
            b = t;
        }
```
![ref_vs_out1](https://cloud.githubusercontent.com/assets/25159667/23218418/a9866e7c-f935-11e6-995b-1efefafc59a8.gif)



<i><b>Ref</b></i>
 <i><b>Out</b></i> 
 
 
 ![ref_vs_out](https://cloud.githubusercontent.com/assets/20840005/23070031/26611812-f543-11e6-97f3-84e5466032a0.png)
 
 
### An<a hraf=https://msdn.microsoft.com/en-us/library/0yw3tz5k.aspx> anonymous method</a> cannot access the <i><b>Ref</b></i> or  <i><b>Out</b></i> parameters of an outer scope.
Also we can't use<a href=https://msdn.microsoft.com/en-us/library/14akc2c7.aspx> the ref and out</a> keywords for the following kinds of methods:
<ul>
<li>Async methods, which we define by using the async modifier.
<li>Iterator methods, which include a yield return or yield break statement.
</ul>

####Why we would ever want to pass <a href=http://www.growingwiththeweb.com/2013/03/c-passing-reference-type-by-ref.html> a reference type into a method using the ref keyword</a>, or why the C# compiler even allows this. Using ref on a reference type is actually slightly different to not using it. The difference is that the ref keyword makes it a reference (pointer) to the variable, not just the object. This allows assigning to the source variable of the parameter from within the method.

```C#
class Program
{
    static void Main(string[] args)
    {
        List<int> listA = new List<int> { 1, 2, 3 };
        List<int> listB = new List<int> { 1, 2, 3 };

        Update(listA);
        UpdateRef(ref listB);

        Console.WriteLine("listA");
        foreach (var val in listA)
            Console.WriteLine(val);

        Console.WriteLine("listB");
        foreach (var val in listB)
            Console.WriteLine(val);
    }

    static void Update(List<int> list)
    {
        list = new List<int>() { 4, 5, 6 };
    }

    static void UpdateRef(ref List<int> list)
    {
        list = new List<int>() { 4, 5, 6 };
    }
}
```
####Here is the output produced by the program:

![ref_vs_out_list_output](https://cloud.githubusercontent.com/assets/25159667/23655939/ec488e96-0350-11e7-9aac-7d45ed31d704.JPG)

Notice how listB contains the new List but listA doesn’t. This is because we had a reference to the variable listB.
