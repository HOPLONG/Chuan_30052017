
app.controller('FAQCtrl', function ($scope, $http) {

    $scope.lisDSPhanHoi = [];
    var nguoiduyet = $('#nguoiduyet').val();
    // Lấy list DS phản hồi
    $http.get(window.location.origin + '/api/Api_HT_PHAN_HOI_PHAN_MEM/GetHT_PHAN_HOI_PHAN_MEM/' + nguoiduyet)
    .then(function (response) {
        if (response.data) {
            $scope.lisDSPhanHoi = response.data;
        }
    }, function (error) {
        console.log(error);
    });

    $scope.showdata = function () {
        if ($("#item-{{$index}}").css("display") == "none") {
            $("#item-{{$index}}").css({ "display": "block" });
        }
        else {
            $("#item-{{$index}}").css({ "display": "block" });
        }
    }
})