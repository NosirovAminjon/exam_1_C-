// task 1

// int n = int.Parse(Console.ReadLine());

// int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

// int cnt = 1;
// int max = 1;

// for (int i = 1; i < n; i++)
// {
//     if (a[i] == a[i - 1])
//         cnt++;
//     else
//         cnt = 1;

//     if (cnt > max)
//         max = cnt;
// }
// Console.WriteLine(max);

// task 2

//    int n = int.Parse(Console.ReadLine
//    int[] arr = Array.ConvertAll(
//        Console.ReadLine().Split(),
//        int.Parse
//
//    bool isPalindrome = true;
//     for (int i = 0; i < n / 2; i++)
//     {
//         if (arr[i] != arr[n - 1 - i])
//         {
//         isPalindrome = false;
//         break;
//     }
//     }
//     Console.WriteLine(isPalindrome ? "Yes" : "No");
//     }

// task 3

// string s = Console.ReadLine();

// int vowels = 0;
// int consonants = 0;

// foreach (char c in s.ToLower())
// {
//     if (c >= 'a' && c <= 'z')
//     {
//         if ("aeiou".Contains(c))
//             vowels++;
//         else
//             consonants++;
//     }
// }

// Console.WriteLine("Vowels: " + vowels);
// Console.WriteLine("Consonants: " + consonants);


///
// task 4


// task 5

// int n = int.Parse(Console.ReadLine());

// int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

// int max = a[0];

// for (int i = 1; i < n; i++)
// {
//     if (a[i] > max)
//         max = a[i];
// }

// Console.WriteLine(max);

// task 6

// int n = int.Parse(Console.ReadLine());

// int Sum(int a)
// {
//     if (a < 10)
//     return a;

//     return Sum(a % 10 + Sum(a / 10));
// }
// Console.WriteLine(Sum(n));

// task 7

// void Multiply(ref int a, ref int b)
// {
//     a *= 2;
//     b *= 2;
// }

// int a = 3;
// int b = 5;

// Multiply(ref a, ref b);

// Console.WriteLine("a = " + a);
// Console.WriteLine("b = " + b);



