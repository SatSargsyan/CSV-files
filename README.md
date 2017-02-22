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



<i><b>Ref</b></i>
 <i><b>Out</b></i> 
 
 
 ![ref_vs_out](https://cloud.githubusercontent.com/assets/20840005/23070031/26611812-f543-11e6-97f3-84e5466032a0.png)

