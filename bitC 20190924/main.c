#define _CRT_SECURE_NO_WARNINGS 1

#include<stdio.h>
#include<math.h>
/*
unsigned int reverse_bit(unsigned int value);
��������ķ���ֵ��value�Ķ�����λģʽ�����ҷ�ת���ֵ��

�磺
��32λ������25���ֵ�������и�λ��
00000000000000000000000000011001
��ת�󣺣�2550136832��
10011000000000000000000000000000
���������أ�
2550136832
*/
unsigned int  reverse_bit(unsigned int value)
{
	int i = 0;
	unsigned int sum = 0;
	for(i = 0;i < 32;i++)
	{
		sum += ((value>>i)&1) * pow((double)2,31-i);
	}
	return sum;
}

int Average1(int a,int b)
{
	return a+(b-a)/2;
}
int Sum(int a,int b)//��������
{
	return (((a&b)<<1) + (a^b));
}

int Average(int a,int b)//������ƽ����
{
	return (((a&b)) + (a^b)>>1);
}
//0000 1010
//0000 0010

int AppearOnce(int *arr,int len)//��һ������ֻ����һ�ε���
{
	int i = 0;
	int tmp = 0;
	for(i = 0;i < len;i++)
	{
		tmp ^= arr[i];
	}
	return tmp;
}

/*
a,b,c,��������
���	���
a > b   1
a == b 	0
a < b   -1
������
if   for  >  <
*/
int Max(int a,int b)
{
	return ((a-b)>>31) ? -1 : (a-b ? 1 : 0);
}


int main()
{

	//int arr[] = {1,4,2,8,1,4,2,6,8};
	//int len = sizeof(arr)/sizeof(arr[0]);
	//int ret = AppearOnce(arr,len);
	printf("%d\n",Max(20,10));

	//printf("%d\n",Sum(10,30));

	return 0;
}

