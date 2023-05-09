namespace Lab3 {
    public abstract class CipherFactory {
        
        public static Cipher CreateCipher(CipherType cipherType) {

            Cipher? cipher = cipherType switch {
                CipherType.Cesar => new CesarCipher(),
                CipherType.Vigenere => new VigenereCipher(),
                _ => throw new Exception(),
            };
            return cipher;
        }
    }
}
