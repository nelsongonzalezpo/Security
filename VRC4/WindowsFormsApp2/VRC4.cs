using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2
{
    public class VRC4
    {
        private string plainText;
        private string keyRC4;
        private string keyVigenere;
        private int[] keyStreamRC4;
        private int[] keyVigenereInt;
        private int randomValue;



        public VRC4(string plainText, string keyRC4, string keyVigenere, int randomValue)
        {
            this.plainText = plainText;
            this.keyRC4 = keyRC4;
            this.keyVigenere = keyVigenere;
            this.randomValue = randomValue;

        }

        private void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public string encrypt()
        {
           
            int[] vectorS = new int[256];
            char[] vectorKeyVigenere = new char[plainText.Length];
            char[] vectorKeyRC4 = new char[256];
            int[] keyTransformedRC4 = new int[256];
            int[] keyTransformedVigenere = new int[plainText.Length];
            int[] keyStream = new int[plainText.Length];
            char[] keyStreamChar = new char[plainText.Length];
            int[] plainTextIntVector = new int[plainText.Length];
            int[] encryptIntVector = new int[plainText.Length];
            char[] encruptCharVector = new char[plainText.Length];
            int[] finalEncryptedIntMessage = new int[plainText.Length];
            char[] finalEncryptedCharMessage = new char[plainText.Length];
            int[] desencryptIntVector = new int[plainText.Length];
            char[] desencryptCharVector = new char[plainText.Length];
            int[] primeraMitad = new int[randomValue];
            int[] segundaMitad = new int[encryptIntVector.Length - randomValue];
            int[] primeraMitadFinal = new int[randomValue];
            int[] segundaMitadFinal = new int[encryptIntVector.Length - randomValue];
            char[] primerMitadFinalChar = new char[randomValue];
            char[] segundaMitadFinalChar = new char[encryptIntVector.Length - randomValue];
            int[] mitadesCombinadesEncriptadasInt = new int[plainText.Length];
            string mitadesCombinadesEncriptadas;
           


            //Se inicializa el el vector de 255 valores, y el vector con la llave hasta q este se llene. (Y)
            for (int i = 0; i < vectorS.Length; i++)
            {
                vectorS[i] = i;
                vectorKeyRC4[i] = keyRC4[i % keyRC4.Length];

            }
            //A segura el tamano de la llave de Vigenere al del PlainText
            for (int i = 0; i < plainText.Length; i++)
            {
                vectorKeyVigenere[i] = keyVigenere[i % keyVigenere.Length];
            }
            //cambia el vector de caracteres con la LLAVE a su valor decimales de assci y los mete a otro vector. (Y)
            for (int i = 0; i < vectorS.Length; i++)
            {
                keyTransformedRC4[i] = (int)vectorKeyRC4[i];

            }
            //Convierte la llave a decimales de ascii.
            for (int i = 0; i < plainText.Length; i++)
            {
                keyTransformedVigenere[i] = (int)vectorKeyVigenere[i];
            }


            keyVigenereInt = keyTransformedVigenere;
            //cambia el PlainText de char a valores decimales ASCII. (Y)
            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextIntVector[i] = (int)plainText[i];
            }



            //
            //
            //


            Console.Write("PASO 1.- SE IMPRIME EL VECTOR 255 VALORES: "); // (N)
            for (int i = 0; i < vectorS.Length; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(vectorS[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("PASO 2.- SE IMPRIME LA LLAVE HASTA QUE EL VECTOR ESTE LLENO: "); //(N)
            for (int i = 0; i < vectorS.Length; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(vectorKeyRC4[i] + " ");
            }

            //
            Console.WriteLine("\n");
            Console.WriteLine("PASO 3.- VECTOR DE LA LLAVE DE VIGENERE: ");
            Console.WriteLine(vectorKeyVigenere);
            Console.WriteLine(plainText);
            //
            Console.WriteLine();
            Console.WriteLine("PASO 4.- VECTOR DE LLAVE DE VIGENERE A FORMATO ASCII");
            for (int i = 0; i < plainText.Length; i++)
            {
                Console.Write(keyTransformedVigenere[i] + " ");
            }

            Console.WriteLine("\n");
            Console.Write("PASO 5.- SE IMPRIME EL VECTOR LLAVE CON SUS VALORES EN DECIMAL ASCII: "); //(N)
            for (int i = 0; i < vectorS.Length; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(keyTransformedRC4[i] + " ");
            }
            Console.WriteLine();

            /// 
            /// 
            ///

            //parte importante 2

            //Algoritmo KSG   (Y)
            int j = 0;
            for (int i = 0; i < vectorS.Length; i++)
            {

                j = (j + vectorS[i] + keyTransformedRC4[i]) % 256;
                swap(ref vectorS[i], ref vectorS[j]);



            }
            Console.WriteLine();
            /// 
            ///
            ///
            Console.Write("PASO 6.- VECTOR GENERADOR DESPSUES DE LA PERMUTACION: "); //(N)
            for (int i = 0; i < vectorS.Length; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(vectorS[i] + " ");
            }
            Console.WriteLine();

            ///
            ///
            ///

            //Algortimo pRGA  (Y)
            int a = 0;
            int b = 0;
            int k = 0;
            int valorKey;
            while (k < plainText.Length)
            {
                a = (a + 1) % 256;
                b = (b + vectorS[a]) % 256;
                swap(ref vectorS[a], ref vectorS[b]);
                valorKey = (vectorS[a] + vectorS[b]) % 256;
                keyStream[k] = vectorS[valorKey];
                k++;


            }

            keyStreamRC4 = keyStream;
            ///
            ///
            Console.WriteLine();
            Console.Write("PASO 7.- Vector S PERMUTADO DE NUEVO CONE PRGA");  //(n)
            //final permutation again. 
            for (int i = 0; i < vectorS.Length; i++)
            {
                if (i % 16 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(vectorS[i] + " ");
            }
            Console.WriteLine("\n");
            ///
            ///
            Console.WriteLine("PASO 8.- KEYSTREAM CREADO POR EL PLAINTEXT: " + plainText);
            foreach (var x in keyStream)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //KEYSTREAM EN CHAR FORMAT
            for (int i = 0; i < plainText.Length; i++)
            {
                keyStreamChar[i] = (char)keyStream[i];
            }

            Console.WriteLine("PASO 9.- KEYSTREAM EN FORMATO DE CHAR");
            foreach (var x in keyStreamChar)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("PASO 10.- FORMATO ASCCI DEL PLAINTEXT ");
            foreach (var x in plainTextIntVector)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            ///
            ///
            ///

            for (int i = 0; i < plainText.Length; i++)
            {
                encryptIntVector[i] = keyStream[i] ^ plainTextIntVector[i];
            }
            Console.WriteLine();
            Console.WriteLine("PASO 11.- VECTOR DE ENTEROS ENCRIPTADO CON XOR: ");
            foreach (var x in encryptIntVector)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");


            ///AQUI EMPIEZA LO NUEVO
            
            for (int i = 0; i < randomValue; i++)
            {
                primeraMitad[i] = encryptIntVector[i];
            }
            
            int s = 0;
            for (int i = randomValue; i < encryptIntVector.Length; i++)
            {
                segundaMitad[s] = encryptIntVector[i];
                s++;
            }
           
            for (int i = 0; i < primeraMitad.Length; i++)
            {
                if (keyTransformedVigenere[i] + primeraMitad[i] > 255)
                {
                    primeraMitadFinal[i] = keyTransformedVigenere[i] + primeraMitad[i] - 256;
                }
                else
                {
                    primeraMitadFinal[i] = keyTransformedVigenere[i] + primeraMitad[i];
                }
            }
          
            for (int i = 0; i < segundaMitad.Length; i++)
            {
                if (keyTransformedVigenere[i] + segundaMitad[i] > 255)
                {
                    segundaMitadFinal[i] = keyTransformedVigenere[i] + segundaMitad[i] - 256;
                }
                else
                {
                    segundaMitadFinal[i] = keyTransformedVigenere[i] + segundaMitad[i];
                }
            }
          
            for (int i = 0; i < primeraMitad.Length; i++)
            {
                primerMitadFinalChar[i] = (char)primeraMitadFinal[i];
            }
           
            for (int i = 0; i < segundaMitad.Length; i++)
            {
                segundaMitadFinalChar[i] = (char)segundaMitadFinal[i];
            }
            


            mitadesCombinadesEncriptadas = String.Concat(primerMitadFinalChar) + String.Concat(segundaMitadFinalChar);

            Console.Write(mitadesCombinadesEncriptadas);
            ///NUEVO
            ///
            Console.WriteLine(plainText.Length);
            Console.WriteLine(mitadesCombinadesEncriptadas.Length);

            /// SE ENCRIPTA CON VIGENERE
            /// 
            /*
            for (int i = 0; i < plainText.Length; i++)
            {
                if (keyTransformedVigenere[i] + encryptIntVector[i] > 255)
                {
                    finalEncryptedIntMessage[i] = keyTransformedVigenere[i] + encryptIntVector[i] - 256;
                }
                else
                {
                    finalEncryptedIntMessage[i] = keyTransformedVigenere[i] + encryptIntVector[i];
                }
            }*/

            //PEGA LAS DOS MITADES YA ENCRIPTADAS
            mitadesCombinadesEncriptadasInt = primeraMitadFinal.Concat(segundaMitadFinal).ToArray();
            Console.WriteLine("PASO 12.- VECTOR DE ENTEROS ENCRIPTADO CON VIGENERE: ");
            foreach (var x in mitadesCombinadesEncriptadasInt)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PASO 13.- MENSAJE FINAL ENCRIPTADO: ");
            Console.WriteLine(mitadesCombinadesEncriptadas);
            Console.WriteLine();

            return mitadesCombinadesEncriptadas;
        }





        public string desencrypt(string encryptedMessage)
        {
            int[] desencryptIntVector = new int[encryptedMessage.Length];
            int[] desencryptIntVectorVigenere = new int[encryptedMessage.Length];
            char[] desencryptCharVector = new char[encryptedMessage.Length];
            int[] encryptedMessageInt = new int[encryptedMessage.Length];
            int[] primeraMitadEncriptada = new int[randomValue];
            int[] segundaMitadEncriptada = new int[encryptedMessage.Length - randomValue];
            int[] primeraMitadEncriptadaFinal = new int[randomValue];
            int[] segundaMitadEncriptadaFinal = new int[encryptedMessage.Length - randomValue];
            char[] primerMitadDesencriptadaFinalChar = new char[randomValue];
            char[] segundaMitadDesencriptadaFinalChar = new char[encryptedMessage.Length - randomValue];
            int[] mensajeEncriptadoFinalInt = new int[encryptedMessage.Length];
            string mensajeDesencriptado;
            int[] desencryptIntVectorF = new int[encryptedMessage.Length];
            char[] desencryptCharVectorF = new char[encryptedMessage.Length];
         
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                encryptedMessageInt[i] = (int)encryptedMessage[i];
            }
            Console.WriteLine("PASO 14.- MENSAJE ENCRIPTADO EN FORMATO DECIMAL: ");
            foreach (var x in encryptedMessageInt)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            ///NUEVO

            for (int i = 0; i < randomValue; i++)
            {
                primeraMitadEncriptada[i] = encryptedMessageInt[i];
            }
            ///NUEVO
            int s = 0;
            for (int i = randomValue; i < encryptedMessage.Length; i++)
            {
                segundaMitadEncriptada[s] = encryptedMessageInt[i];
                s++;
            }
            
            for (int i = 0; i < primeraMitadEncriptada.Length; i++)
            {
                if (primeraMitadEncriptada[i] >= keyVigenereInt[i])
                {
                    primeraMitadEncriptadaFinal[i] = primeraMitadEncriptada[i] - keyVigenereInt[i];
                }
                else
                {
                    int p1 = 255 - keyVigenereInt[i];
                    int p2 = primeraMitadEncriptada[i] + 1;
                    int result = p1 + p2;
                    primeraMitadEncriptadaFinal[i] = result;
                }


            }
            
            for (int i = 0; i < segundaMitadEncriptada.Length; i++)
            {
                if (segundaMitadEncriptada[i] >= keyVigenereInt[i])
                {
                    segundaMitadEncriptadaFinal[i] = segundaMitadEncriptada[i] - keyVigenereInt[i];
                }
                else
                {
                    int p1 = 255 - keyVigenereInt[i];
                    int p2 = segundaMitadEncriptada[i] + 1;
                    int result = p1 + p2;
                    segundaMitadEncriptadaFinal[i] = result;
                }


            }

            ///NUEVO
            for (int i = 0; i < primeraMitadEncriptada.Length; i++)
            {
                primerMitadDesencriptadaFinalChar[i] = (char)primeraMitadEncriptadaFinal[i];
            }
            ///NUEVO
            for (int i = 0; i < segundaMitadEncriptada.Length; i++)
            {
                segundaMitadDesencriptadaFinalChar[i] = (char)segundaMitadEncriptadaFinal[i];
            }

            mensajeEncriptadoFinalInt = primeraMitadEncriptadaFinal.Concat(segundaMitadEncriptadaFinal).ToArray();

            ///NUEVO
            for (int i = 0; i < plainText.Length; i++)
            {
                desencryptIntVectorF[i] = keyStreamRC4[i] ^ mensajeEncriptadoFinalInt[i];
            }
            ///NUEVO
            for (int i = 0; i < plainText.Length; i++)
            {
                desencryptCharVectorF[i] = (char)desencryptIntVectorF[i];
            }
            ///NUEVO
          
            
            ///NUEVO
            ///
            Console.WriteLine("PASO 15.- MENSAJE ENCRIPTADO EN FORMATO DECIMAL:");
            foreach(var x in mensajeEncriptadoFinalInt)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            //
            mensajeDesencriptado = String.Concat(desencryptCharVectorF);
            Console.WriteLine("EL MENSAJE FINAL DESCENCRIPTADO ES:" + mensajeDesencriptado);
            return mensajeDesencriptado; ;
        }

    }
}

