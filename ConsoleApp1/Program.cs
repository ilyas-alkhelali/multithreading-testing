//короче, получилось если много больших задач, то быстрее справляется Thread 
//если много маленьких Task
//это можно проверить меняя количество итераций в Action.cs

using ConsoleApp1;

const int ITERATOR_LENGTH = 1000;

WithThreads withThreads = new();
WithTasks withTasks = new();
ThreadsInf threadInf = new();

//threadInf.GetMaxes();
withTasks.ActionStart(ITERATOR_LENGTH);
//withThreads.ActionStart(ITERATOR_LENGTH);