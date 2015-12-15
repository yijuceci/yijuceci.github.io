@*@Code
    ViewData("Title") = "Product"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<div>
    <h1>所有產品</h1>
    <ul id='products' />
</div>
<div>
    <label for="prodId">ID:</label>
    <input type="text" id="prodId" size="5" />
    <input type="button" value="Search" onclick="find();" />
    <p id="product" />
</div>
<script type="text/javascript">
    $(function () {
        // 傳送 AJAX 請求
        $.getJSON("/api/Products/",
        function (data) {
            // 成功, data 會包含所有產品列表
            $.each(data, function (key, val) {
                // 格式化文字資料，以方便顯示
                var str = val.Name + ': $' + val.Price;

                // 將產品資料建置成 li項目，然後加入 ul 元素中
                $('<li/>', { html: str }).appendTo($('#products'));
            });
        });
    });

    function find() {
        // 取的輸入的id
        var id = $('#prodId').val();

        // 傳送 AJAX 請求
        $.getJSON("/api/products/" + id,
        function (data) {
            // 成功
            var str = data.Name + ':' + data.Price;
            $('#product').html(str);
        })
        .fail( // 失敗
        function (jqXHR, textStatus, err) {
            $('#product').html('Error: ' + err);
        });
    }
</script>*@