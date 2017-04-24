# AES_Optimize
My optimizations for AES runtime on PC architecture during my university study. Includes linear states of n-bit words + SIMD + AES NI

This implementation suggests we don't know PC platform AES to be run on.
Obj-oriented approach is used to construct the exact implementation depending on the processor of Computer.
The code contains some implementation with using enhancements:
1) state as linear byte array with lot of assigment operations;
2) state as linear array of 32 words with bit operations
3) state as linear array of 32-words using SIMD (MMX, SSE) operations
4) implementation based on AES NI instructions
