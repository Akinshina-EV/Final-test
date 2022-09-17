string[] GetArray(string text) 
{
    string[] array = text.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
    return array; 
} 

string GetResult(string[] array) 
{ 
string result = String.Empty;
    for (int i = 0; i < array.Length; i++) 
    { 
        if(array[i].Length <= 3)
        {
            result = result + " " + array[i];                    
        }
    }
return result; 
}

Console.Write("Введите элементы массива через пробел: "); 
string elements = Console.ReadLine(); 
string[] baseArray = GetArray(elements); 
string result = GetResult(baseArray);
string[] resultArray = GetArray(result); 

Console.WriteLine("Первоначальный массив: [{0}]", string.Join(", ", baseArray));
Console.WriteLine("Итоговый массив из строк, длина которых меньше или равна 3: [{0}]", string.Join(", ", resultArray));
