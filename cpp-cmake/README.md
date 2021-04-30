# C++ version of Gilded Rose refactoring kata and some other stuff
# Gilded Rose is based on material found here: https://github.com/emilybache/GildedRose-Refactoring-Kata

## Prerequisites
* CMake version >= 3.13
* C++ compiler that supports C++11

## How to build and run tests in a terminal
 
### Build tests

    $ cd ${GIT_FOLDER}/GildedRose-Refactoring-Kata/cpp
    $ mkdir build
    $ cd build
    $ cmake ..
    $ cmake --build .

    To run it go to build/src and run GildedRose

### Show available tests

    $ cd ${GIT_FOLDER}/GildedRose-Refactoring-Kata/cpp/build
    $ ctest -N
   
### Run all tests

    $ ctest

### Run all tests with verbose output

    $ ctest -VV


## How to run coverage
First, make sure you have gcov and gcovr installed
from build directory run: 
gcovr -r ../src --object-directory src/CMakeFiles/src.dir --html-details --output coverage.html

Then open coverage.html in a browser

