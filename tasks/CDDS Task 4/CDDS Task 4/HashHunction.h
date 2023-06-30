#pragma once
#include <functional>
namespace HashFunction {

    typedef std::function<unsigned int(const char*, unsigned int)> HashFunc;

    // implementation of a basic addition hash
    unsigned int badHash(const char* data, unsigned int length);
    int BKDRHash(const char* data, unsigned int length);
    int ELFHash(unsigned char* data, unsigned int size);
    // ADD YOUR FUNCTIONS HERE
    // a helper to access a default hash function
    static HashFunc Default = badHash;

}