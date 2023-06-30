#include "pch.h"
#include "CppUnitTest.h"
#include "../doublyLinkedListyBoi/DoubleLinkedList.h"
#include "../doublyLinkedListyBoi/DoubleLinkedList.cpp"
#include "../doublyLinkedListyBoi/Node.h"
#include "../doublyLinkedListyBoi/Node.cpp"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			DoubleLinkedList list{};
			for (size_t i = 0; i < 5; i++)
			{
				list.PushBack(i);
			}

			DoubleLinkedList newList{};
			newList.
				
			Assert::AreSame(list, );
		}
	};
}
