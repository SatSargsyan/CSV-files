# Ref vs Out

<h3>They're pretty much the same - the only difference is that a variable you pass as an out parameter doesn't need to be initialized but passing it as a ref parameter it has to be set to something.</h3>
 
 ![ref_vs_out](https://cloud.githubusercontent.com/assets/20840005/23070031/26611812-f543-11e6-97f3-84e5466032a0.png)

### <i><b>Ref</b></i>:  variable need to be initialized 
Part of the program demonstrating ref:
```C#
 int i = 3; // Variable need to be initialized 
            Console.WriteLine("before calling method ref {0}", i);
            sampleMethod_for_ref(ref i);
            Console.WriteLine("after calling method ref {0}", i);
```
And method:
```C#
public static void sampleMethod_for_ref(ref int sampleData)
        {
            sampleData++;
        }
```
### <i><b>Out</b></i>:  variable needn't be initialized 
Part of the program demonstrating out:
```C#
 int k, j; // Variable needn't be initialized 
            Console.WriteLine(sampleMethod_for_out(out k, out j));
            Console.WriteLine("after calling method out {0}, {1}", k, j);
```
Method:
```C#
        public static int sampleMethod_for_out(out int sampleData1, out int sampleData2)
        {
            sampleData1 = 10;
            sampleData2 = 20;
            return sampleData1+sampleData2;
        }
```
#### The output is:
![ref_vs_out](https://cloud.githubusercontent.com/assets/25159667/23677805/194f91e2-039b-11e7-8e6b-ae698160b7b5.JPG)

#### This part of the program demonstrated swap without using ref and with ref:
```C#
            int a = 5;
            int b = 15;
            Console.WriteLine("after calling method swap {0}, {1}", a, b);
            swap(ref a,ref b);
            Console.WriteLine("after calling method swap {0}, {1}", a, b);
```
#### If we don't use ref, after swap a and b didn't change its value

```C#
public static void swap(int  a, int  b)
        {
            int t = a;
            a = b;
            b = t;
        }
```
#### For t changing a and b values we are using ref:
```C#
public static void swap(ref int  a, ref int  b)
        {
            int t = a;
            a = b;
            b = t;
        }
```

![ref_vs_out1](https://cloud.githubusercontent.com/assets/25159667/23218418/a9866e7c-f935-11e6-995b-1efefafc59a8.gif)

### Swapping Two Strings
Swapping strings is a good example of passing reference-type parameters by reference. In the example, two strings, str1 and str2, are initialized in Main and passed to the SwapStrings method as parameters modified by the ref keyword. The two strings are swapped inside the method and inside Main as well.
```C#
string s1 = "Barev";
            string s2 = "hayer";
            Console.WriteLine("before calling method swap: {0}  {1}", s1, s2);
            swap(ref s1, ref s2);
            Console.WriteLine("after calling method swap: {0}  {1}", s1, s2);
```
And swap for string:
```C#
            public static void swap(ref string a, ref string b)
        {
            string t = a;
            a = b;
            b = t;
        }
```
![ref_for_string](https://cloud.githubusercontent.com/assets/25159667/23677278/ef1d46be-0398-11e7-9cfb-3579aba0d34f.JPG)

If we don't use "ref" for "string", result will be same as in time "int". it is changing nothing  after calling method swap. So it's neccesary to use "ref".

 
### An<a hraf=https://msdn.microsoft.com/en-us/library/0yw3tz5k.aspx> anonymous method</a> cannot access the <i><b>Ref</b></i> or  <i><b>Out</b></i> parameters of an outer scope.
Also we can't use<a href=https://msdn.microsoft.com/en-us/library/14akc2c7.aspx> the ref and out</a> keywords for the following kinds of methods:
<ul>
<li>Async methods, which we define by using the async modifier.
<li>Iterator methods, which include a yield return or yield break statement.
</ul>

#### Why we would ever want to pass <a href=http://www.growingwiththeweb.com/2013/03/c-passing-reference-type-by-ref.html> a reference type into a method using the ref keyword</a>, or why the C# compiler even allows this. Using ref on a reference type is actually slightly different to not using it. The difference is that the ref keyword makes it a reference (pointer) to the variable, not just the object. This allows assigning to the source variable of the parameter from within the method.

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
#### Here is the output produced by the program:

![ref_vs_out_list_output](https://cloud.githubusercontent.com/assets/25159667/23655939/ec488e96-0350-11e7-9aac-7d45ed31d704.JPG)

ListB contains the new List but listA doesn’t. This is because we had a reference to the variable listB.

### Passing Arrays Using ref and out

Like all out parameters, an<a href= https://msdn.microsoft.com/en-us/library/szasx730.aspx> out parameter of an array type</a> must be assigned before it is used; that is, it must be assigned by the callee. For example:

```C#
    static void TestMethod1(out int[] arr)
    {
        arr = new int[10];   // definite assignment of arr
    }
    
```   
  In this example, the array theArray is declared in the caller (the Main method), and initialized in the FillArray method. Then, the array elements are returned to the caller and displayed.
 
```C#
class TestOut
{
    static void FillArray(out int[] arr)
    {
        // Initialize the array:
        arr = new int[5] { 1, 2, 3, 4, 5 };
    }

    static void Main()
    {
        int[] theArray; // Initialization is not required

        // Pass the array to the callee using out:
        FillArray(out theArray);

        // Display the array elements:
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < theArray.Length; i++)
        {
            Console.Write(theArray[i] + " ");
        }

        // Keep the console window open in debug mode.
             Console.ReadKey();
    }
}
  
```
#### Here is the output produced by the program:
![out_for_array](https://cloud.githubusercontent.com/assets/25159667/23674928/0a78a03c-0391-11e7-961d-41514935a3bb.JPG)


Like all ref parameters, a <a href= https://msdn.microsoft.com/en-us/library/szasx730.aspx> ref parameter of an array type</a> must be definitely assigned by the caller. Therefore, there is no need to be definitely assigned by the callee. A ref parameter of an array type may be altered as a result of the call. For example, the array can be assigned the null value or can be initialized to a different array. For example:

```C#
    static void TestMethod2(ref int[] arr)
    {
        arr = new int[10];   // arr initialized to a different array
    }
```

In this example, the array theArray is initialized in the caller (the Main method), and passed to the FillArray method by using the ref parameter. Some of the array elements are updated in the FillArray method. Then, the array elements are returned to the caller and displayed.
```C#
class TestRef
{
    static void FillArray(ref int[] arr)
    {
        // Create the array on demand:
        if (arr == null)
        {
            arr = new int[10];
        }
        // Fill the array:
        arr[0] = 1111;
        arr[4] = 5555;
    }

    static void Main()
    {
        // Initialize the array:
        int[] theArray = { 1, 2, 3, 4, 5 };

        // Pass the array using ref:
        FillArray(ref theArray);

        // Display the updated array:
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < theArray.Length; i++)
        {
            Console.Write(theArray[i] + " ");
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
   
```
#### Here is the output produced by the program:
![ref_for_array](https://cloud.githubusercontent.com/assets/25159667/23675233/290dd8d6-0392-11e7-9819-6c9923801d26.JPG)
