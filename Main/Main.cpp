// Main.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <time.h>
#include "../AesTransformation/AesTransformation.h"
using namespace std;
int _tmain(int argc, _TCHAR* argv[])
{
	unsigned char temp2[16] = { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff };
	clock_t t;
	unsigned char* res = new unsigned char[32];
	unsigned char key[32] = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f };
	IFactory* fact = CreateFactory();
	AesTransform* ciph = fact->CreateForDecryption(16, key, 16);
	t = clock();
	ciph->AesECBEncrypt(temp2, res);
	t = clock() - t;
	for (auto i = 0; i<32; i++)
	{
		printf("%02x ", res[i]);
	}
	printf("It took me %d clocks (%f seconds).\n", t, ((float)t) / CLOCKS_PER_SEC);
	delete[]res;
	delete ciph;
	delete fact;
	return 0;
}

