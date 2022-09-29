using System.ComponentModel.DataAnnotations;
using System.Linq;

int[] array1 = { 098, 234, 456, 234, 765, 095,23,8, 8976, 234, 345 };

  array1.Where(x => x < 100)
        .ToList()
        .ForEach(x=>Console.WriteLine(x));


//foreach (var num in myNewCollection)
//{
//    Console.WriteLine(num);
//}


//for (int i = 0; i < myNewCollection.Count(); i++)
//{
//    Console.WriteLine(myNewCollection);
//}
