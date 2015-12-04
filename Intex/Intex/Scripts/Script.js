$('#add-sample').on('click', function (e) {
    e.preventDefault();

    $('.enter-sample-info').append('<div class="sample" style="display:none"><div class="row"><div class="col-xs-12"><p class="lead">Enter Sample Information</p></div></div><div class="row"><div class="form-group col-md-2"><label class="control-label">Quantity (mg)</label><input type="number" value="" class="form-control" /></div><div class="form-group col-md-2"><label class="control-label">Date Arrived</label><input type="date" value="" class="form-control" /></div><div class="form-group col-md-2"><label class="control-label">Date Due</label><input type="date" value="" class="form-control" /></div><div class="form-group col-md-2"><label class="control-label">Claimed Weight</label><input type="number" value="" class="form-control" /></div><div class="form-group col-md-2"><label class="control-label">Actual Weight</label><input type="number" value="" class="form-control" /></div><div class="form-group col-md-2"><label class="control-label">MTD</label><input type="number" value="" class="form-control" /></div></div><div class="row"><div class="form-group col-xs-12"><label class="control-label">Appearance</label><textarea rows="5" class="form-control"></textarea></div></div></div>');
    $('.sample').slideDown();
});

$('#submit-compound').on('click', function (e) {
    e.preventDefault();
    $('.enter-info').fadeOut(function () {
        $('.confirmation').fadeIn();
    });
});

$('#add-customer').on('click', function (e) {
    e.preventDefault();
    $('form').fadeOut(function () {
        $('.confirmation').fadeIn();
    });
});

$('#compound-mass').on('keyup', function (e) {
    var val = e.target.value;
    if (val.match(/[a-zA-Z]/)) {
        $('.error-message').html('Please enter numerical values only.')
    } else {
        $('.error-message').html('');
    }
});