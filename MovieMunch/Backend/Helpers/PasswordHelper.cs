using System.Security.Cryptography;
using System.Text;

public class PasswordHelper
{
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); /*Convert byte to hexadecimal format like 255 in byte and ff in 
                                                                                  * hexadecimal,That's why even the user password will save as 
                                                                                  * hashed to database, and once it called in user login, it is d
                                                                                  * etected as the right password for that specific email or user.*/
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2")); 
            }
            return builder.ToString();  // Return hashed password as a string 
        }
    } 

    public static bool VerifyPassword(string inputPassword, string storedHash)
    {
        string hashedInputPassword = HashPassword(inputPassword); /*So, dito bago i verify yung password eh pina Hash muna ito or pina 
                                                                   * convert muna sa hexadecimal yung user input na password*/
        return hashedInputPassword == storedHash;  /* Compare hashes, so yun nga, na dedetect nya yung hashes na same kase nga nag coconvert
                                                   lang naman ito ng byte to hexa and then yun yung ginagawa ng hashes, pinag-sasama-sama 
                                                   nyalang yung mga hexadecimal*/
    }

    /*Hindi porket parang naka random na letter yung mga naga save sa database eh ibig sabihin na ni randomized lang yung number na 
     maga save sa database... Yun po eh pina convert lang para makuha padin sya sa login. */
}
