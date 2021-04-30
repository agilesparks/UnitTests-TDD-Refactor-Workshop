set(SRC_LIB_NAME src)
add_library(${SRC_LIB_NAME})
target_sources(${SRC_LIB_NAME} PRIVATE GildedRose CInterestingFunctions.cpp InterestingClass.cpp UnInstantiableClass.cpp CUnbelievableComplexStruct.h UnbelievableComplexClass.h ExternalCalls.h)
target_include_directories(${SRC_LIB_NAME} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR})


set(EXECUTABLE GildedRose)
add_executable(${EXECUTABLE})
target_sources(${EXECUTABLE} PUBLIC Main.cpp)
target_link_libraries(${EXECUTABLE} src )
set_property(TARGET ${EXECUTABLE} PROPERTY CXX_STANDARD 11)