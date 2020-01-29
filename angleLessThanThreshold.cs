/*
MIT License

Copyright (c) 2020 billy brickner

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/


// A function to determine if the distance between two angles is less than a threshold. 
// Choosing a threshold of 1 will return True for all angles. Choosing threshold of 0 will only return True for an exact match. 
//
// Note: These are floating point operations. Choosing a threshold of 0 is not a good idea because of rounding errors. 
// Instead try a value close to 0.
//
// Author : Billy Brickner
// 
// param[in] angle1 : Angle in radians
// param[in] angle2 : Angle in radians
// param[in] threshold : A float from 0-1. 0 Being an exact match, 1 accepts all angles.
//
// return True if the difference between the angles is less than a threshold. 
bool angle_less_than_threshold(float angle1, float angle2, float threshold){
    # This uses the sin function to evaluate the difference of angles.
    # By having a frequency of 500 milihertz the modified sine function repeats every 2pi radians
    # Sine is also fairly linear when angle differences are close to 0
    float angleDistance = abs(sin((angle1 - angle2)/2));
    return angleDistance < threshold;
}
