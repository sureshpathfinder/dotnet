using System;
class first
{
public static void Main(string []arg)
{
if(arg.Length==0)
	Console.WriteLine("Arguments Not passed");
else
{
	Console.WriteLine("Values By For Loop");

	for(int i=0;i<arg.Length;i++)
		Console.WriteLine("Value in index {0} is {1}",i,arg[i]);

	Console.WriteLine("Values By ForEach Loop");

	foreach(string s in arg)
			Console.WriteLine(s);

}

}
}