; (function ($) {
    if ($().datepicker()) {
        $.fn.datepicker.dates["cn"] = {
            days: ["星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六"],
            daysShort: ["周日", "周一", "周二", "周三", "周四", "周五", "周六"],
            daysMin: ["日", "一", "二", "三", "四", "五", "六"],
            months: ["一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"],
            monthsShort: ["1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月"],
            format: "yyyy-mm-dd"
        }
        $.fn.datepicker.defaults["language"] = "cn";
        $('.datepicker').datepicker({ autoclose: true });
        $('.datemulti').datepicker({ multidate: true, multidateSeparator: "," });
        $('.daterange').datepicker({ autoclose: true });
    }
    $("body").on("click", ".J_clearDatas", function () {
        var $el = $(this);
        $el.prev().datepicker("clearDates");
    });

    //父元素input-group定义J_initDatas_parent样式,子元素为J_initDatas;
    $('body').on('click', '.J_initDatas', function () {
        var
        $el      = $(this),
        $par     = $el.closest('.J_initDatas_parent'),
        $pickers = $par.find('input'),
        arr_val  = $el.data('initdata').split(','),
        isCheck  = $el.attr('data-checked') == 'false' ?  true : false;

        if (isCheck) {
            $.each($pickers, function (i,v) {
                $pickers.eq(i).datepicker('setDates', arr_val[i]);
            });
            $el.attr('data-checked','true').text('清除');
        } else {
            $pickers.datepicker("clearDates");
            $el.attr('data-checked','false').text('当天');
        }
    });
}(jQuery));