public class Solution {
    // TC => O(m + mlogn)
    // SC => O(n)
    public int ShortestWay(string source, string target) {
        if(string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target)){
            return -1;
        }
        if(source.Equals(target)){
            return 1;
        }

        int sp = 0, tp = 0, count = 1;

        Dictionary<char, List<int>> map = new Dictionary<char, List<int>>();
        for(int i = 0; i< source.Length; i++){
            map.TryAdd(source[i], new List<int>());
            map[source[i]].Add(i);
        }

        while(tp < target.Length){
            var c = target[tp];
            if(!map.ContainsKey(c)){
                return -1;
            }

            var list = map[c];
            int k = list.BinarySearch(sp);
            if(k < 0){
                k = -k -1;
            }
        }
    }
    // TC => O(m*n)
    // SC => O(1)
    public int ShortestWay1(string source, string target) {
        if(string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target)){
            return -1;
        }
        if(source.Equals(target)){
            return 1;
        }

        int sp = 0, tp = 0, count = 1;

        HashSet<char> hashset = new HashSet<char>(source.ToCharArray());
        
        while(tp < target.Length){
            var c = target[tp];

            if(!hashset.Contains(c)){
                return -1;
            }

            if(source[sp] == c){
                sp++;
                tp++;
            }
            else{
                sp++;
            }
            if(sp == source.Length && tp < target.Length){
                count++;
                sp = 0;
            }
        }
        return count;
    }
}