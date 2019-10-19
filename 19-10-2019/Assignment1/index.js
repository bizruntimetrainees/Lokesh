$(document).ready(function(){
    $('#on').fadeIn(function(){
        $("#first").hide();
        $('#second').hide();
        $('#third').hide();
    });

    
    $('#on').click(function(){
        $("#first").show();
        $('#second').hide();
        $('#third').hide();
    });  
    
    
    $('#on1').click(function(){
        $("#second").show();
        $('#first').hide();
        $('#third').hide();
    });

    
    $('#on2').click(function(){
        $('#third').show();
        $('#second').hide();
        $('#first').hide();
    });
    
});


  