namespace Freedom.Utility.Cryptography.Interface
{
    public interface IEncryption
    {
        string DecryptString(string encryptedText);

        string EncryptString(string data);
    }
}