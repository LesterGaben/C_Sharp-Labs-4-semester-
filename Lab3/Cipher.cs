namespace Lab3 {
    public abstract class Cipher {

        protected string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        
        public abstract string Encrypt(string plainMessage, string key);

        
        public abstract string Decrypt(string encryptedMessage, string key);
    }
}
