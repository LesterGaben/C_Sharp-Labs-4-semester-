namespace Lab3 {

    public class VigenereCipher: Cipher {

        //генерація повторюваного пароля
        private string GetRepeatKey(string password, int n) {
            string? p = password;
            while (p.Length < n) {
                p += p;
            }

            return p.Substring(0, n);
        }

        private string Vigenere(string text, string password, bool encrypting = true) {
            string? repeatKey = GetRepeatKey(password, text.Length);
            string newText = "";

            for (int i = 0; i < text.Length; i++) {
                int letterIndex = alphabet.IndexOf(text[i]);
                int codeIndex = alphabet.IndexOf(repeatKey[i]);
                if (letterIndex < 0) {
                    
                    newText += text[i].ToString();
                }
                else {
                    newText += alphabet[(alphabet.Length + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % alphabet.Length].ToString();
                }
            }

            return newText;
        }

        
        public override string Encrypt(string plainMessage, string password) => Vigenere(plainMessage, password);

       
        public override string Decrypt(string encryptedMessage, string password) => Vigenere(encryptedMessage, password, false);
    }
}
