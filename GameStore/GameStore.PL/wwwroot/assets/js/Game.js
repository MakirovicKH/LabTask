$('#review-form').on('submit', (e) => {
    e.preventDefault();

    const productId = $(location).attr('href').split('/').pop();
    const comment = $('#comment').val();

    $.post('/game/addcomment/',
        {
            id: productId,
            comment: comment
        },
        function (data, status) {
            if (status == "success") {

            }
        }
    );
})