namespace Lab3 {
    public class CesarCipher : Cipher {

        private string Cesar(string text, int key) {

            string newText = "";
            for (int i = 0; i < text.Length; i++) {
                int index = alphabet.IndexOf(text[i]);
                if (index < 0) {
                    
                    newText += text[i].ToString();
                }
                else {
                    int codeIndex = (alphabet.Length + index + key) % alphabet.Length;
                    newText += alphabet[codeIndex];
                }
            }

            return newText;
        }

        
        public override string Encrypt(string plainMessage, string key) => Cesar(plainMessage, Int32.Parse(key));
        
        public override string Decrypt(string encryptedMessage, string key) => Cesar(encryptedMessage, -Int32.Parse(key));
    }
}
