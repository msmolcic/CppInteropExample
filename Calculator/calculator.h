#pragma once

#ifdef CALCULATOR_EXPORTS
#define CALCULATOR_API __declspec(dllexport)
#else
#define CALCULATOR_API __declspec(dllimport)
#endif

extern "C" {
	int CALCULATOR_API Sum(const int first, const int second);
	int CALCULATOR_API Diff(const int first, const int second);
	int CALCULATOR_API Mult(const int first, const int second);
	int CALCULATOR_API Div(const int first, const int second);
}
