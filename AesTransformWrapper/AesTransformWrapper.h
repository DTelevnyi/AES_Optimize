// AesTransformWrapper.h

#pragma once
#include "../AesTransformation/AesTransformation.h"
using namespace System;

namespace AesTransformWrapper {

	public ref class AesTransformWrap
	{
	public:
		AesTransformWrap(size_t mesSize, array<System::Byte> ^encrKey, unsigned keySize, bool isEncrypting)
		{
			pin_ptr<unsigned char> arr_pin = &encrKey[0];
			fact = CreateFactory();
			if (isEncrypting)
				aes = fact->CreateForEncryption(mesSize, arr_pin, keySize);
			else
				aes = fact->CreateForDecryption(mesSize, arr_pin, keySize);
		}
		~AesTransformWrap()
		{
			delete fact;
			delete aes;
		}
		void ECBEncrypt(array<System::Byte> ^init, array<System::Byte> ^decr)
		{
			pin_ptr<unsigned char> arr_in = &init[0];
			pin_ptr<unsigned char> arr_out = &decr[0];
			aes->AesECBEncrypt(arr_in, arr_out);
		}
		unsigned ECBDecrypt(array<System::Byte> ^init, array<System::Byte> ^decr)
		{
			pin_ptr<unsigned char> arr_in = &init[0];
			pin_ptr<unsigned char> arr_out = &decr[0];
			return aes->AesECBDecrypt(arr_in, arr_out);
		}
		void AesCBCEncrypt(array<System::Byte> ^initialText, array<System::Byte> ^encrypted, array<System::Byte> ^initializationVector)
		{
			pin_ptr<unsigned char> arr_in = &initialText[0];
			pin_ptr<unsigned char> arr_out = &encrypted[0];
			pin_ptr<unsigned char> vector = &initializationVector[0];
			aes->AesCBCEncrypt(arr_in, arr_out, vector);
		}
		unsigned AesCBCDecrypt(array<System::Byte> ^initialText, array<System::Byte> ^encrypted, array<System::Byte> ^initializationVector)
		{
			pin_ptr<unsigned char> arr_in = &initialText[0];
			pin_ptr<unsigned char> arr_out = &encrypted[0];
			pin_ptr<unsigned char> vector = &initializationVector[0];
			return aes->AesCBCDecrypt(arr_in, arr_out, vector);
		}
		unsigned GetPaddingSize()
		{
		return	aes->GetPaddingSize();
		}
		void AesCFBEncrypt(array<System::Byte> ^initialText, array<System::Byte> ^encrypted, array<System::Byte> ^initializationVector)
		{
			pin_ptr<unsigned char> arr_in = &initialText[0];
			pin_ptr<unsigned char> arr_out = &encrypted[0];
			pin_ptr<unsigned char> vector = &initializationVector[0];
			aes->AesCFBEncrypt(arr_in, arr_out, vector);
		}
		unsigned AesCFBDecrypt(array<System::Byte> ^initialText, array<System::Byte> ^encrypted, array<System::Byte> ^initializationVector)
		{
			pin_ptr<unsigned char> arr_in = &initialText[0];
			pin_ptr<unsigned char> arr_out = &encrypted[0];
			pin_ptr<unsigned char> vector = &initializationVector[0];
			return aes->AesCFBDecrypt(arr_in, arr_out, vector);
		}
		void AesOFBEncrypt(array<System::Byte> ^initialText, array<System::Byte> ^encrypted, array<System::Byte> ^initializationVector)
		{
			pin_ptr<unsigned char> arr_in = &initialText[0];
			pin_ptr<unsigned char> arr_out = &encrypted[0];
			pin_ptr<unsigned char> vector = &initializationVector[0];
			aes->AesOFBEncrypt(arr_in, arr_out, vector);
		}
		unsigned AesOFBDecrypt(array<System::Byte> ^initialText, array<System::Byte> ^encrypted, array<System::Byte> ^initializationVector)
		{
			pin_ptr<unsigned char> arr_in = &initialText[0];
			pin_ptr<unsigned char> arr_out = &encrypted[0];
			pin_ptr<unsigned char> vector = &initializationVector[0];
			return aes->AesOFBDecrypt(arr_in, arr_out, vector);
		}
	private:
		AesTransform* aes;
		IFactory* fact;
	};
}
