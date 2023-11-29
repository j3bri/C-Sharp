#pragma once

#include <string>
#include <vector>
#include <memory>

namespace Code_Forces
{
	class Program : public std::enable_shared_from_this<Program>
	{
	public:
		static void Main(std::vector<std::wstring> &args);
	};
}
