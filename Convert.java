import java.util.*;
import java.util.stream.Collector;
import java.util.stream.Collectors;

public class Convert {

    public static void main(String[] args)
    {

        // Arrays 

        int[] array1 = {1,2,3,4,5,6,7};


        // Arrays to fixed size list

        List<int[]> fixedList = Arrays.asList(array1);    // Returns fixed size list

        System.out.println("Size : " + fixedList.size());


        // Arrays to usual list

        List<Integer> usingToList = Arrays.stream(array1).boxed().toList();        // boxed() => Stream<Integer>

        List<Integer> usingCollect = Arrays.stream(array1).boxed().collect(Collectors.toList());


        // Arrays to String

        System.out.println(usingToList);
        System.out.println(usingCollect);


        // Arrays to Set

        Set<Integer> arrToSet = Arrays.stream(array1).boxed().collect(Collectors.toSet());

        System.out.println(arrToSet);


        // Sum of array elements

        int sum = Arrays.stream(array1).sum();

        System.out.println(sum);


        // Max and Min Element

        int max = Arrays.stream(array1).max().getAsInt();
        int min = Arrays.stream(array1).min().getAsInt();

        System.out.printf("Max : %d\nMin : %d",max,min);
    }

}