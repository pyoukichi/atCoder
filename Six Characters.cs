public class Six_Characters{
    public static void Main(){
        // Your code here!
        var str = System.Console.ReadLine();
        string res = "";
        
        for(int i = 0; i < (6 / str.Length);i++)
        {
            res = res + str;
        }
        
        System.Console.WriteLine(res);
    }
}
