Console.WriteLine(GetSumFromInt(12346));

int GetSumFromString(string number)
{
int result = 0;

for (int i = 0; i < number.Length; i++)
{
result += int.Parse(number[i].ToString());
}

return result;
}

int GetSumFromInt(int number)
{
int result = 0;

for (int i = number; i > 0; i /= 10)
{
result += i % 10;
}

return result;
}