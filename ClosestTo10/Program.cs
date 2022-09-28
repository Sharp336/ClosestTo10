List<int> inputlist = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToList();
// Принимаем ввод и разбиваем на список чисел
if (inputlist.Contains(10)) Console.WriteLine(10);
// если в списке есть 10 сразу выводим его
else
{
    inputlist = (new ArraySegment<Int32>(inputlist.OrderBy(x => Math.Abs(x - 10)).ToArray(), 0 , 2)).ToList();
    // в противном случае сортируем и берём 2 ближайших к 10 значения 
    Console.WriteLine((Math.Abs(10 - inputlist[1]) == Math.Abs(10 - inputlist[0]) && inputlist[0] < inputlist[1]) ? inputlist[1] : inputlist[0]);
    //выводим второе только если оба равноудалены, т.к. в этом случае им будет большее
}