#include "Class1.h"

using namespace comimportthingy;
using namespace Platform;

Class1::Class1()
{
}
Windows::Foundation::IAsyncAction^ Class1::EnableDevelopmentModeAsync(bool enable) 
{
	return Windows::Xbox::System::Internal::DevelopmentKit::DevelopmentKitProperties::EnableDevelopmentModeAsync(enable);
}

Windows::Foundation::IAsyncAction^ comimportthingy::Class1::EnableDevelopmentModeExAsync(bool enable, bool deleteDevStorage)
{
	return Windows::Xbox::System::Internal::DevelopmentKit::DevelopmentKitProperties::EnableDevelopmentModeExAsync(enable, deleteDevStorage);
}
