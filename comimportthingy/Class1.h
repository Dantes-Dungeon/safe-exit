#pragma once

namespace comimportthingy
{
    public ref class Class1 sealed
    {
    public:
        Class1();
        Windows::Foundation::IAsyncAction^ EnableDevelopmentModeAsync(bool enable);
        Windows::Foundation::IAsyncAction^ EnableDevelopmentModeExAsync(bool enable, bool deleteDevStorage);
    };
}
