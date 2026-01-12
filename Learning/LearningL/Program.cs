int[] nums = { 12, 5, 19, 63, 47, 28, 34, 16, 14 };
/*
Array.Sort(nums);
Console.WriteLine($"Максимальный элемент: {nums[nums.Length-1]}");
*/
int max = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
        max = nums[i];
}
Console.WriteLine($"Максимальный элемент: {max}");