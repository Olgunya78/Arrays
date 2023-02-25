// У нас есть массив array с n элементов. Нам требуется найти элемент, совпадающий с некоторым значением, который может определять пользователь 
// если array [index] = find - алгоритм завершил свою работу

int[] array = {1, 125, 37, 49, 55, 64, 78, 64, 82};
int n = array.Length;
int find = 64;
int index = 0;
while (index < n)
{
if (array[index] == find)
{
  Console.WriteLine(index);
  break;
}
  // index = index + 1;
  index++;
}
