<?php

function triangle($number) {
    for ($i=1;$i<=$number;$i++) {
        for ($j=1;$j<=$i;$j++) {
            echo "O ";
        }
        echo "\n";
    }
}

triangle(9);
?>
