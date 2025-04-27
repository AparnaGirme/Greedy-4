public class Solution {
    // TC => O(n)
    // SC => O(1)
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        if(tops.Length != bottoms.Length){
            return -1;
        }
         int result = FindMinRotation(tops, bottoms, tops[0]);
         if(result != -1){
            return result;
         }

         return FindMinRotation(tops, bottoms, bottoms[0]);
    }

    public int FindMinRotation(int[] tops, int[] bottoms, int target){
        int aRotation = 0, bRotation = 0;
        for(int i = 0; i< tops.Length; i++){
            if(tops[i] != target && bottoms[i] != target){
                return -1;
            }
            if(tops[i] != target){
                aRotation++;
            }
            if(bottoms[i] != target){
                bRotation++;
            }
        }
        return Math.Min(aRotation, bRotation);
    }
}