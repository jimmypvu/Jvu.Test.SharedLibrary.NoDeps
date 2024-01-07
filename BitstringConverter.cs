using System;
using System.Text;

namespace Jvu.Test.SharedLibrary.NoDeps
{
  public class BitstringConverter
  {
    public string ConvertStringToBinary(string input)
    {
      StringBuilder sb = new StringBuilder();

      foreach (char c in input.ToCharArray())
      {
        string binary = Convert.ToString(c, 2).PadLeft(8, '0');
        sb.Append(binary);
      }

      return sb.ToString();
    }

    public string ConvertBinaryToString(string binaryString)
    {
      // ensure binary string length is a multiple of 8
      int remainder = binaryString.Length % 8;
      if (remainder != 0)
      {
        throw new ArgumentException("Invalid binary string length.");
      }

      StringBuilder stringBuilder = new StringBuilder();

      // convert each 8 bit chunk back to a character
      for (int i = 0; i < binaryString.Length; i += 8)
      {
        string chunk = binaryString.Substring(i, 8);
        char character = (char) Convert.ToByte(chunk, 2);
        stringBuilder.Append(character);
      }

      return stringBuilder.ToString();
    }
  }
}
