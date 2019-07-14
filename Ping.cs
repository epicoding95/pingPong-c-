// using System;

// class ping
// {
//   static void Main()
//   {
//       String str = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15";

//     for (str = 0; str <= 10; year ++)
//     {
//       if (str == 3)
//       {
//         str.Replace("3", "ping");
//         console.WriteLine(str);
//       }
//     }
//   }
// }

using System; 
  
class Geeks { 
  
    // Main Method 
    public static void Main() 
    { 
  
        // string 
        String str = "123456"; 
  
        Console.WriteLine("OldString : " + str); 
  
        // replace the character 's' with 'G' 
        Console.WriteLine("NewString: " + str.Replace("3", "ping")); 
  
        // oldString will remain unchanged 
        // its return the modified string 
        Console.WriteLine("\nOldString: " + str); 
  
        // replace the character 'e' with space ' ' 
        Console.WriteLine("NewString: " + str.Replace("4", "pong")); 
    } 
} 
