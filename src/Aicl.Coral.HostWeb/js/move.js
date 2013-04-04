//http://stackoverflow.com/questions/561844/how-to-move-div-with-the-mouse-using-jquery
//$("#titleBar").draggit("#whatToDrag");
function (el) {
    var thisdiv = this;
    var thistarget = $(el);
    var relX;
    var relY;
    var targetw = thistarget.width();
    var targeth = thistarget.height();
    var docw;
    var doch; var ismousedown=false;

    thistarget.css('position','absolute');
    thistarget.css('width', targetw);
    thistarget.css('height', targeth);


    thisdiv.bind('mousedown', function(e){
        var pos = $(el).offset();
        var srcX = pos.left;
        var srcY = pos.top;

        docw = $('body').width();
        doch = $('body').height();

        relX = e.pageX - srcX;
        relY = e.pageY - srcY;

        ismousedown = true;
    });

    $(document).bind('mousemove',function(e){ 
        if(ismousedown)
        {
            targetw = thistarget.width();
            targeth = thistarget.height();

            var maxX = docw - targetw - 10;
            var maxY = doch - targeth - 10;

            var mouseX = e.pageX;
            var mouseY = e.pageY;

            var diffX = mouseX - relX;
            var diffY = mouseY - relY;

            // check if we are beyond document bounds ...
            if(diffX < 0)   diffX = 0;
            if(diffY < 0)   diffY = 0;
            if(diffX > maxX) diffX = maxX;
            if(diffY > maxY) diffY = maxY;

            $(el).css('top', (diffY)+'px');
            $(el).css('left', (diffX)+'px');
        }
    });

    $(window).bind('mouseup', function(e){
        ismousedown = false;
    });

    return this;
}

// drags from http://css-tricks.com/snippets/jquery/draggable-without-jquery-ui/
//$('div').drags();

(function($) {
    $.fn.drags = function(opt) {

        opt = $.extend({handle:"",cursor:"move"}, opt);

        if(opt.handle === "") {
            var $el = this;
        } else {
            var $el = this.find(opt.handle);
        }

        return $el.css('cursor', opt.cursor).on("mousedown", function(e) {
            if(opt.handle === "") {
                var $drag = $(this).addClass('draggable');
            } else {
                var $drag = $(this).addClass('active-handle').parent().addClass('draggable');
            }
            var z_idx = $drag.css('z-index'),
                drg_h = $drag.outerHeight(),
                drg_w = $drag.outerWidth(),
                pos_y = $drag.offset().top + drg_h - e.pageY,
                pos_x = $drag.offset().left + drg_w - e.pageX;
            $drag.css('z-index', 1000).parents().on("mousemove", function(e) {
                $('.draggable').offset({
                    top:e.pageY + pos_y - drg_h,
                    left:e.pageX + pos_x - drg_w
                }).on("mouseup", function() {
                    $(this).removeClass('draggable').css('z-index', z_idx);
                });
            });
            e.preventDefault(); // disable selection
        }).on("mouseup", function() {
            if(opt.handle === "") {
                $(this).removeClass('draggable');
            } else {
                $(this).removeClass('active-handle').parent().removeClass('draggable');
            }
        });

    }
})(jQuery);