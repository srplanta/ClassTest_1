//Console.WriteLine("Hello, World!");

using System.ComponentModel;

//string a = "aghbbqr137pppeee";


/***************************************************************
/                          Question 2                          /
 **************************************************************/
//input array
Console.Write("Type in a string (1st two characters must be numbers):\t");
string inputString = Console.ReadLine();
char[] stringToCharArray = new char[inputString.Length];
int[] charToIntArray = new int[stringToCharArray.Length];
int sum = 0;

//convert input string into character array
for (int i = 0; i < inputString.Length; i++)
{
    stringToCharArray[i] = Convert.ToChar(inputString[i]);
}
//char[] inputStringToCharArray = { '1', '2', 'z', '8', 'c', '9', 'f' };
//FOLLOW LOGIC BELOW
//if Z, it equals PRODUCT of previous 2 consective numbers
//if C, replace it with '0'
//if F, it equals SUM of previous 2 consective numbers
//---------------------------------------------------------------

//display input array
Console.Write("Original Array: \t");
for (int i = 0; i < stringToCharArray.Length; i++)
{
    Console.Write($"{stringToCharArray[i]},");
}
Console.WriteLine();
//Console.WriteLine($"Array Type:\t{inputStringToCharArray.GetType()}");
//---------------------------------------------------------------

//manipulate Z, C & F values
//some info
//char.GetNumericValue() returns numaric value in unicode formate (superseeds ASCII)
for (int i = 0; i < stringToCharArray.Length; i++)
{
    if (char.IsNumber(stringToCharArray[i]))
    {
        charToIntArray[i] = (int)char.GetNumericValue(stringToCharArray[i]);
    }
    else
    {
        if (stringToCharArray[i] == 'z')
        {
            charToIntArray[i] = charToIntArray[i - 2] * charToIntArray[i - 1];
            //inputCharToIntArray[i] = (int)char.GetNumericValue(inputStringToCharArray[i - 2]) * (int)char.GetNumericValue(inputStringToCharArray[i - 1]);
            //int charToNum = (int)char.GetNumericValue(inputStringToCharArray[i - 2]) * (int)char.GetNumericValue(inputStringToCharArray[i - 1]);
            //Console.Write(charToNum + ", ");
            //sum += charToNum;
            //inputStringToCharArray[i] = Convert.ToChar(
            //            Convert.ToString(
            //                (int)char.GetNumericValue(inputStringToCharArray[i - 2]) + (int)char.GetNumericValue(inputStringToCharArray[i - 1])
            //                ));
            //int step1 = (int)char.GetNumericValue(inputStringToCharArray[i - 2]) + (int)char.GetNumericValue(inputStringToCharArray[i - 1]);
            //string step2 = Convert.ToString(step1);
            ////if step2 is double digit, it throughs exception; string must be single character
            //char step3 = Convert.ToChar(step2);
            //inputStringToCharArray[i] = step3;
        }
        else if (stringToCharArray[i] == 'f')
        {
            charToIntArray[i] = charToIntArray[i - 2] + charToIntArray[i - 1];
            //inputCharToIntArray[i] = (int)char.GetNumericValue(inputStringToCharArray[i - 2]) + (int)char.GetNumericValue(inputStringToCharArray[i - 1]);
            //int charToNum = (int)char.GetNumericValue(inputStringToCharArray[i - 2]) + (int)char.GetNumericValue(inputStringToCharArray[i - 1]);
            //Console.Write(charToNum + ", ");
            //sum += charToNum;

            //inputStringToCharArray[i] = Convert.ToChar(
            //    Convert.ToString(
            //        ((int)char.GetNumericValue(inputStringToCharArray[i - 2]) + (int)char.GetNumericValue(inputStringToCharArray[i - 1]))
            //        ));
        }
        else if (stringToCharArray[i] == 'c')
        {
            charToIntArray[i] = 0;
            //int charToNum = 0;
            //Console.Write(charToNum + ", ");
            //sum += charToNum;
            //inputStringToCharArray[i] = '0';
        }
        else
        {
            charToIntArray[i] = 1;
        }
    }
}
//---------------------------------------------------------------

//display manipulated array
Console.Write("Manipulated Array: \t");
for (int i = 0; i < charToIntArray.Length; i++)
{
    Console.Write($"{charToIntArray[i]},");
}
Console.WriteLine();
//---------------------------------------------------------------

//calculate SUM of manipulated array
//double sum = 0;
for (int i = 0; i < charToIntArray.Length; i++)
{
    sum += charToIntArray[i];
    //sum += (int)char.GetNumericValue(inputStringToCharArray[i]);
}

//display SUM of manipulated array
Console.WriteLine($"Sum of array:\t\t{sum}");
Console.ReadKey();
