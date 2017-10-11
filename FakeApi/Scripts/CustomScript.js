$(function () {

    //$('.swagger-ui-wrap #logo').removeAttr('href').html('<img class="logo__img" alt="swagger" height="30" width="30" src="images/logo_small-png"><span class="logo__title">Demo</span>').attr('href','#');

    $('.description-link').addClass('selected');
    $('.snippet-link').removeClass('selected');
    $('.signature-container .description').attr('style', "display: Block;")
    $('.signature-container .snippet').attr('style', "display: none;")

    //$('#resource_V195BasicApi').addClass('active');
    //$('#BasicApi_endpoint_list').attr('style', "display: Block;")
    //$('#Account_endpoint_list').attr('style', "display: Block;")
    //$('#V195BasicApi_endpoint_list').attr('style', "display: Block;")
    //$('#V295BasicApi_endpoint_list').attr('style', "display: Block;")
    //$('#swagger-ui-container .info .info_description').html('<p>MarkDown文件說明<a href="../../Extra/readme.html">請點我</a><br></p>')
});
