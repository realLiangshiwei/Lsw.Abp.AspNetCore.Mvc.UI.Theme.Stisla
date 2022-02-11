/**
 *
 * You can write your JS code here, DO NOT touch the default style file
 * because it will make it harder for you to update.
 * 
 */

"use strict";

$(function(){
    
    setInterval(function(){
        for(let btn of $(".btn-close")){
            $(btn).removeClass("btn-close");
            $(btn).addClass("close");
            $(btn).append('<span aria-hidden=\\"true\\">&times;</span>');
        }
    },500)
})
