

using System.Collections;

List<int> numbers = new(Enumerable.Range(1, 11));  // we can use extension methos here because list coolection inherrited the IEnumerable interface
var result = numbers.Where(x => x > 7);  
foreach (var item in result)
{
    Console.WriteLine(item);
}

ArrayList array = new() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, "Hello"};  // we don't have access to extension methos in linq here
// becaus this collection doesn't inherrit the Enumerable class

//var result = array.Where(x => x > 7);      => error
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
