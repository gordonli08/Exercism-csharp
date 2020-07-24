using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string result = new string(phoneNumber.Where(Char.IsDigit).ToArray());
        if (result[0] == '1') {
            result = result.Substring(1);
        }
        if (result.Length != 10 || result[0] == '0' || result[3] == '0' || result[0] == '1' || result[3] == '1') {
            throw new ArgumentException();
        }
        return result;
    }
}